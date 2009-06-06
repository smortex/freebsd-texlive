# New ports collection makefile for:	texlive-amsfonts
# Date created:		26/01/2009 16:02:40
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	amsfonts
PORTREVISION=	2
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	TeX fonts from the American Mathematical Society.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bib/ams/amsj.bib:${PORTSDIR}/print/texlive-ams

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
