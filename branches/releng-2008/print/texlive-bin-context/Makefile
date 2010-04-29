# New ports collection makefile for:	texlive-bin-context
# Date created:		26/01/2009 16:03:06
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-context
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The ConTeXt macro package.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.pdftex.cnf:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
