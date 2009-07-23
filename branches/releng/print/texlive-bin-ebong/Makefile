# New ports collection makefile for:	texlive-bin-ebong
# Date created:		26/01/2009 16:06:22
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-ebong
PORTREVISION=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	The bin-ebong package

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
