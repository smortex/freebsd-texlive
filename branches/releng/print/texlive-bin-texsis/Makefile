# New ports collection makefile for:	texlive-bin-texsis
# Date created:		26/01/2009 16:04:59
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-texsis
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Plain TeX macros for Physicists.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.tex.cnf:${PORTSDIR}/print/texlive-bin-tex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
