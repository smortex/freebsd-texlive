# New ports collection makefile for:	texlive-texlive.infra
# Date created:		13/03/2010 04:19:59
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	texlive.infra
PORTVERSION=	20120907
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	basic TeX Live infrastructure

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
