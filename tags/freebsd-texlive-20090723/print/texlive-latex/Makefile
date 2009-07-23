# New ports collection makefile for:	texlive-latex
# Date created:		26/01/2009 16:03:01
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	latex
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A TeX macro package that defines LaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.latex.cnf:${PORTSDIR}/print/texlive-bin-latex

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
