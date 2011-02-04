# New ports collection makefile for:	texlive-kpathsea
# Date created:		13/03/2010 04:19:24
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	kpathsea
PORTVERSION=	20110204
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Path searching library for TeX-related files.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
