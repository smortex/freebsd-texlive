# New ports collection makefile for:	texlive-bin-dvi2tty
# Date created:		26/01/2009 16:03:41
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-dvi2tty
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Produce ASCII from DVI.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
