# New ports collection makefile for:	texlive-pgf
# Date created:		26/01/2009 16:10:08
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pgf
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Create PostScript and PDF graphics in TeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/xkeyval/xkeyval.tex:${PORTSDIR}/print/texlive-xkeyval

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
